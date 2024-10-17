namespace pratik_constructor
{
    public class BabyClass
    {
        private string _babyName;
        private string _babySurname;
        private DateTime _babyDate;

        public BabyClass()
        {
            _babyDate = DateTime.Now;
            Console.WriteLine($"Ingaaaa ! , Doğduğu gün ve saat: {_babyDate}");
        }
        public BabyClass(string babyName, string babySurname)
        {
            _babyName = babyName;
            _babySurname = babySurname;
            _babyDate = DateTime.Now;
            Console.WriteLine($"Ingaaaa ! , Doğduğu gün ve saat: {_babyDate}");
        }

        public string AddName
        {
            get
            {
                return _babyName;
            }

            set
            {
                _babyName = value;
            }
        }
        public string AddSurname
        {
            get
            {
                return _babySurname;
            }
            set
            {
                _babySurname = value;
            }

        }
        public DateTime AddBirthDate
        {
            get
            {
                return _babyDate;
            }

            set
            {
                _babyDate = value;
            }
        }

    }


}
