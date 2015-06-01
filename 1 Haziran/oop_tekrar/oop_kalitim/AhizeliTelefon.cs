namespace oop_kalitim
{
    //base: kalıtım veren. 
    //derived: Kalıtım alan. 
    class AhizeliTelefon : Telefon
    {
        public bool Kablolu { get; set; }

        public override string Cal()
        {
            return "zırrr zırr zır";
        }
    }
}
