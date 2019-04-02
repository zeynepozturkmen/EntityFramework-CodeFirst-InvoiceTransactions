namespace CodeFist_Invoice
{
    internal class UrunSecilen //Invoice Detailse eklenenler
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; } //Miktar
        public decimal UnitPrice { get; set; } //Urun Fiyat

        //toplam tutar eklemiş ama toplamTutar=Invoice Header'da  var.
        //toplamTutar=! Invoice Details'de yok.
        public decimal VatAmount { get; set; }

    }
}