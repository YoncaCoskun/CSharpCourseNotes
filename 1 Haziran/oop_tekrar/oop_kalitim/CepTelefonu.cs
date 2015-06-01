namespace oop_kalitim
{
    class CepTelefonu : Telefon
    {
        public int Ram { get; set; }
        public string BataryaModel { get; set; }

        public override string Cal()
        {
            return "drili drili drili";
        }
    }
}
