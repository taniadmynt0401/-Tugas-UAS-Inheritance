
using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Meminta pengguna untuk memasukkan informasi pemesanan tiket
            Console.Write("Masukkan Nama: ");
            string name = Console.ReadLine();
            Console.Write("Masukkan Nomor Kartu Vaksin: ");
            string vaccinationCardNumber = Console.ReadLine();
            Console.Write("Masukkan NIK: ");
            string nik = Console.ReadLine();
            Console.Write("Masukkan Nomor Telepon: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Masukkan Nomor Kartu: ");
            string cardNumber = Console.ReadLine();
            Console.Write("Masukkan Alamat Rumah: ");
            string homeAddress = Console.ReadLine();

            // Membuat objek TicketBooking dan mengatur nilai properti menggunakan konstruktor
            TicketBooking ticketBooking = new TicketBooking(name, vaccinationCardNumber, nik, phoneNumber, cardNumber, homeAddress);

            // Memanggil method BookTicket untuk memesan tiket
            ticketBooking.BookTicket();
        }
    }
}