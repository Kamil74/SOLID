﻿namespace OpenClose.Class;


    public class PdfInvoiceSaver : IInvoiceSaver
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine("Saving invoice as pdf");
        }
        
    }
    
