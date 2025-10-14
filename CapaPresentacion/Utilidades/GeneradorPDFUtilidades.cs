using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using CapaEntidad;

namespace CapaPresentacion.Utilidades
{
    public class GeneradorPDFUtilidades
    {
        public static void GenerarReporteUtilidad(UtilidadFlete utilidad, DetalleGastoFlete detalle, List<GastoFlete> gastos, string rutaArchivo)
        {
            // Crear el documento
            Document documento = new Document(PageSize.LETTER, 50, 50, 50, 50);

            try
            {
                // Crear el escritor de PDF
                PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(rutaArchivo, FileMode.Create));
                documento.Open();

                // Definir fuentes
                Font fuenteTitulo = FontFactory.GetFont("Arial", 18, Font.BOLD, BaseColor.BLACK);
                Font fuenteSubtitulo = FontFactory.GetFont("Arial", 14, Font.BOLD, BaseColor.BLACK);
                Font fuenteNormal = FontFactory.GetFont("Arial", 11, Font.NORMAL, BaseColor.BLACK);
                Font fuenteNegrita = FontFactory.GetFont("Arial", 11, Font.BOLD, BaseColor.BLACK);
                Font fuentePequena = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.DARK_GRAY);

                // ===== ENCABEZADO =====
                Paragraph titulo = new Paragraph("REPORTE DE UTILIDAD DE FLETE\n\n", fuenteTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;
                documento.Add(titulo);

                // Fecha de generación
                Paragraph fechaGen = new Paragraph($"Fecha de generación: {DateTime.Now:dd/MM/yyyy HH:mm}\n\n", fuentePequena);
                fechaGen.Alignment = Element.ALIGN_RIGHT;
                documento.Add(fechaGen);

                // ===== INFORMACIÓN DEL FLETE =====
                documento.Add(new Paragraph("INFORMACIÓN DEL FLETE", fuenteSubtitulo));
                documento.Add(new Paragraph(" ", fuenteNormal)); // Espacio

                PdfPTable tablaInfo = new PdfPTable(2);
                tablaInfo.WidthPercentage = 100;
                tablaInfo.SetWidths(new float[] { 1f, 2f });

                AgregarCeldaInfo(tablaInfo, "No. Flete:", utilidad.IdFlete.ToString(), fuenteNegrita, fuenteNormal);
                AgregarCeldaInfo(tablaInfo, "Cliente:", utilidad.NombreCliente, fuenteNegrita, fuenteNormal);
                AgregarCeldaInfo(tablaInfo, "Unidad (Placa):", utilidad.Placa, fuenteNegrita, fuenteNormal);
                AgregarCeldaInfo(tablaInfo, "Motorista:", utilidad.NombreMotorista, fuenteNegrita, fuenteNormal);
                AgregarCeldaInfo(tablaInfo, "Fecha Registro:", utilidad.FechaRegistro.ToString("dd/MM/yyyy"), fuenteNegrita, fuenteNormal);

                documento.Add(tablaInfo);
                documento.Add(new Paragraph("\n", fuenteNormal));

                // ===== RESUMEN FINANCIERO =====
                documento.Add(new Paragraph("RESUMEN FINANCIERO", fuenteSubtitulo));
                documento.Add(new Paragraph(" ", fuenteNormal));

                PdfPTable tablaResumen = new PdfPTable(2);
                tablaResumen.WidthPercentage = 100;
                tablaResumen.SetWidths(new float[] { 2f, 1f });

                // Encabezado
                PdfPCell celdaHeader1 = new PdfPCell(new Phrase("Concepto", fuenteNegrita));
                celdaHeader1.BackgroundColor = new BaseColor(200, 200, 200);
                celdaHeader1.Padding = 8;
                celdaHeader1.HorizontalAlignment = Element.ALIGN_LEFT;
                tablaResumen.AddCell(celdaHeader1);

                PdfPCell celdaHeader2 = new PdfPCell(new Phrase("Monto", fuenteNegrita));
                celdaHeader2.BackgroundColor = new BaseColor(200, 200, 200);
                celdaHeader2.Padding = 8;
                celdaHeader2.HorizontalAlignment = Element.ALIGN_RIGHT;
                tablaResumen.AddCell(celdaHeader2);

                // Valor del flete
                AgregarCeldaResumen(tablaResumen, "Valor del Flete", "$" + utilidad.ValorFlete.ToString("N2"), fuenteNegrita, new BaseColor(144, 238, 144));

                // Gastos por categoría
                AgregarCeldaResumen(tablaResumen, "Gastos Camión", "$" + detalle.TotalGastosCamion.ToString("N2"), fuenteNormal, BaseColor.WHITE);
                AgregarCeldaResumen(tablaResumen, "Gastos Varios", "$" + detalle.TotalGastosVarios.ToString("N2"), fuenteNormal, BaseColor.WHITE);
                AgregarCeldaResumen(tablaResumen, "Gastos Producción", "$" + detalle.TotalGastosProduccion.ToString("N2"), fuenteNormal, BaseColor.WHITE);

                // Total gastos
                AgregarCeldaResumen(tablaResumen, "Total Gastos", "$" + utilidad.TotalGastos.ToString("N2"), fuenteNegrita, new BaseColor(255, 200, 200));

                // Línea separadora
                PdfPCell separador = new PdfPCell(new Phrase(" "));
                separador.Colspan = 2;
                separador.Border = PdfPCell.NO_BORDER;
                separador.FixedHeight = 10f;
                tablaResumen.AddCell(separador);

                // Utilidad neta
                BaseColor colorUtilidad = utilidad.UtilidadNeta >= 0 ? new BaseColor(144, 238, 144) : new BaseColor(255, 99, 71);
                AgregarCeldaResumen(tablaResumen, "UTILIDAD NETA", "$" + utilidad.UtilidadNeta.ToString("N2"), fuenteNegrita, colorUtilidad);
                AgregarCeldaResumen(tablaResumen, "Rentabilidad", utilidad.PorcentajeUtilidad.ToString("0.00") + "%", fuenteNegrita, colorUtilidad);

                documento.Add(tablaResumen);
                documento.Add(new Paragraph("\n", fuenteNormal));

                // ===== DETALLE DE GASTOS =====
                if (gastos.Count > 0)
                {
                    documento.Add(new Paragraph("DETALLE DE GASTOS", fuenteSubtitulo));
                    documento.Add(new Paragraph(" ", fuenteNormal));

                    PdfPTable tablaGastos = new PdfPTable(3);
                    tablaGastos.WidthPercentage = 100;
                    tablaGastos.SetWidths(new float[] { 1.5f, 2.5f, 1f });

                    // Encabezados
                    AgregarCeldaHeaderGastos(tablaGastos, "Categoría", fuenteNegrita);
                    AgregarCeldaHeaderGastos(tablaGastos, "Concepto", fuenteNegrita);
                    AgregarCeldaHeaderGastos(tablaGastos, "Monto", fuenteNegrita);

                    // Datos
                    foreach (GastoFlete gasto in gastos)
                    {
                        AgregarCeldaGasto(tablaGastos, gasto.TipoGasto, fuenteNormal);
                        AgregarCeldaGasto(tablaGastos, gasto.Concepto, fuenteNormal);
                        AgregarCeldaGastoMonto(tablaGastos, "$" + gasto.Monto.ToString("N2"), fuenteNormal);
                    }

                    documento.Add(tablaGastos);
                }

                // ===== PIE DE PÁGINA =====
                documento.Add(new Paragraph("\n\n", fuenteNormal));
                Paragraph pie = new Paragraph("Este reporte fue generado automáticamente por el Sistema de Gestión de Fletes.", fuentePequena);
                pie.Alignment = Element.ALIGN_CENTER;
                documento.Add(pie);

                // Línea decorativa al final
                Paragraph linea = new Paragraph("_______________________________________________________", fuentePequena);
                linea.Alignment = Element.ALIGN_CENTER;
                documento.Add(linea);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar el PDF: " + ex.Message);
            }
            finally
            {
                if (documento.IsOpen())
                {
                    documento.Close();
                }
            }
        }

        // Métodos auxiliares
        private static void AgregarCeldaInfo(PdfPTable tabla, string etiqueta, string valor, Font fuenteEtiqueta, Font fuenteValor)
        {
            PdfPCell celdaEtiqueta = new PdfPCell(new Phrase(etiqueta, fuenteEtiqueta));
            celdaEtiqueta.Border = PdfPCell.NO_BORDER;
            celdaEtiqueta.Padding = 5;
            tabla.AddCell(celdaEtiqueta);

            PdfPCell celdaValor = new PdfPCell(new Phrase(valor, fuenteValor));
            celdaValor.Border = PdfPCell.NO_BORDER;
            celdaValor.Padding = 5;
            tabla.AddCell(celdaValor);
        }

        private static void AgregarCeldaResumen(PdfPTable tabla, string concepto, string monto, Font fuente, BaseColor color)
        {
            PdfPCell celdaConcepto = new PdfPCell(new Phrase(concepto, fuente));
            celdaConcepto.BackgroundColor = color;
            celdaConcepto.Padding = 8;
            celdaConcepto.HorizontalAlignment = Element.ALIGN_LEFT;
            tabla.AddCell(celdaConcepto);

            PdfPCell celdaMonto = new PdfPCell(new Phrase(monto, fuente));
            celdaMonto.BackgroundColor = color;
            celdaMonto.Padding = 8;
            celdaMonto.HorizontalAlignment = Element.ALIGN_RIGHT;
            tabla.AddCell(celdaMonto);
        }

        private static void AgregarCeldaHeaderGastos(PdfPTable tabla, string texto, Font fuente)
        {
            PdfPCell celda = new PdfPCell(new Phrase(texto, fuente));
            celda.BackgroundColor = new BaseColor(200, 200, 200);
            celda.Padding = 8;
            celda.HorizontalAlignment = Element.ALIGN_CENTER;
            tabla.AddCell(celda);
        }

        private static void AgregarCeldaGasto(PdfPTable tabla, string texto, Font fuente)
        {
            PdfPCell celda = new PdfPCell(new Phrase(texto, fuente));
            celda.Padding = 6;
            celda.HorizontalAlignment = Element.ALIGN_LEFT;
            tabla.AddCell(celda);
        }

        private static void AgregarCeldaGastoMonto(PdfPTable tabla, string texto, Font fuente)
        {
            PdfPCell celda = new PdfPCell(new Phrase(texto, fuente));
            celda.Padding = 6;
            celda.HorizontalAlignment = Element.ALIGN_RIGHT;
            tabla.AddCell(celda);
        }
    }
}