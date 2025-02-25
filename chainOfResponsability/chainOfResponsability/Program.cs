using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainOfResponsability
{
    internal class Program
    {
        static void main()
        {
            // Crear los manejadores específicos
            var accountHandler = new verificacionHandler();
            var balanceHandler = new checarBalance();
            var paymentHandler = new procesadorPago();

            // Construir la cadena de responsabilidad
            accountHandler.SetNext(balanceHandler).SetNext(paymentHandler);

            // Enviar solicitudes a la cadena y ver la respuesta
            Console.WriteLine(accountHandler.Handle("Verificar cuenta")); 
            Console.WriteLine(accountHandler.Handle("Verificar saldo"));
            Console.WriteLine(accountHandler.Handle("Procesar pago")); 
            Console.WriteLine(accountHandler.Handle("Solicitud desconocida")); 
        }
    }
}
