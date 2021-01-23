using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class İhtiyacKrediManager : IKrediBaseManager
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi ödeme planı hesaplandı.");
        }
    }
}
