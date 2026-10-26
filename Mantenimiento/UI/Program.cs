using Application.DTOs;
using Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // DI (Inyección de dependencias)



            // While de ejecución

            var salir = false;
            while (!salir)
            {
                Console.WriteLine("");
                Console.WriteLine("=== Gestión de Servicios ===");
                Console.WriteLine("1. Consultar por un servicio ingresando su código");
                Console.WriteLine("2. Registrar nuevo técnico");
                Console.WriteLine("3. Consultar técnicos disponibles");
                Console.WriteLine("4. Registrar nuevo servicio");
                Console.WriteLine("0. Salir");

                Console.Write("Opción: ");

                var opcion = Console.ReadLine()?.Trim();

                // Switch de opciones para interactuar

                try
                {
                    switch (opcion) 
                    {
                        case "1": ConsultarServicio(); break;
                        case "2": AltaTecnico(); break;
                        case "3": ListarTecnicos(); break;
                        case "4": RegistrarServicio(); break;
                        case "0": salir = true; break;
                        default: Console.WriteLine("Opción Inválida"); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            }

            void ConsultarServicio()
            {
                var codigo = Pedir("Código de servicio");
                var detalle = servicioService.ConsultarPorCodigo(codigo);

                if (detalle is null)
                {
                    Console.WriteLine($"No existe un servicio con código: {codigo}.");
                    return;
                }

                Console.WriteLine($"Código: {detalle.Codigo}");
                Console.WriteLine($"Descripción: {detalle.Descripcion}");
                Console.WriteLine($"Dirección: {detalle.Direccion}");
                Console.WriteLine($"Técnico: {detalle.Tecnico}");
                Console.WriteLine($"Ciudad: {detalle.Ciudad}");
            }

            void AltaTecnico()
            {
                var dto = new TecnicoDTO(
                    Pedir("DNI"),
                    Pedir("Nombre"),
                    Pedir("Teléfono"),
                    Pedir("Dirección"),
                    Pedir("Especialidad")
                    );

                tecnicoService.Alta(dto);
                Console.WriteLine("Técnico dado de alta correctamente.");
            }

            void ListarTecnicos()
            {
                var lista = tecnicoService.ListarTecnicos();

                if (lista.Count == 0)
                {
                    Console.WriteLine("No hay técnicos registrados.");
                    return;
                }

                foreach (var t in lista)
                    Console.WriteLine($"{t.DNI} | {t.Nombre} | {t.Telefono} | {t.Direccion} | {t.Especialidad}");

            }

            void RegistrarServicio()
            {
                var dto = new RegistrarServicioDTO(
                    Pedir("Código"),
                    Pedir("Descripción"),
                    Pedir("Dirección"),
                    Pedir("DNI del técnico"),
                    Pedir("Código de Ciudad")
                    );

                servicioService.RegistrarServicio(dto);
                Console.WriteLine("Servicio registrado correctamente.");
            }

            string Pedir(string etiqueta)
            {
                Console.Write($"{etiqueta}: ");
                return Console.ReadLine()?.Trim() ?? string.Empty;
            }
        }
    }
}
