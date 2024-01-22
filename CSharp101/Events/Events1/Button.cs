using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Events1
{
    // 1. adım: Olayın tanımlanabilmesi için yeni bir temsilci tanımlanmalı
    public delegate void OlayYakalayıcı();
    internal class Button
    {
        // 2. adım: Temsilci tipinden olay tanımlanır.
        public event OlayYakalayıcı Tikla;

        //3. adım: Olayın çalışacağı mekanizma tanımlanmalıdır.
        public void Calistir()
        {
            if (Tikla != null)
            {
                Tikla();
            }
        }
    }
}
