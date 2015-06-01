namespace oop_kalitim
{
    class Telefon
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Fiyat { get; set; }

        public virtual string Cal()
        {
            return "......";
        }

    }
}
