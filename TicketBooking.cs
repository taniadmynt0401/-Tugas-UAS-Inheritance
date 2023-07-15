using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class TicketBooking
    {
            // Variabel private
            private string name;
            private string vaccinationCardNumber;
            private string nik;
            private string phoneNumber;
            private string cardNumber;
            private string homeAddress;

            // Konstruktor untuk inisialisasi properti
            public TicketBooking(string name, string vaccinationCardNumber, string nik, string phoneNumber, string cardNumber, string homeAddress)
            {
                this.name = name;
                this.vaccinationCardNumber = vaccinationCardNumber;
                this.nik = nik;
                this.phoneNumber = phoneNumber;
                this.cardNumber = cardNumber;
                this.homeAddress = homeAddress;
            }
        // Method untuk memesan tiket dan menampilkan informasi pemesanan
        public void BookTicket()
        {
            Console.WriteLine("Tiket berhasil dipesan untuk:");
            Console.WriteLine("Nama: " + name);
            Console.WriteLine("Nomor Kartu Vaksin: " + vaccinationCardNumber);
            Console.WriteLine("NIK: " + nik);
            Console.WriteLine("Nomor Telepon: " + phoneNumber);
            Console.WriteLine("Nomor Kartu: " + cardNumber);
            Console.WriteLine("Alamat Rumah: " + homeAddress);
        }
    }
}



