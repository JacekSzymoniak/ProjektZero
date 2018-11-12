using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projekt0
{

    public class Adres
    {
        private string _kodPocztowy;
        private string _miasto;
        private string _ulica;
        private int _nrDomu;
        private int _nrMieszkania;

        public string KodPocztowy
        {
            get
            {
                return _kodPocztowy;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Błędna wartość pola KodPocztowy");
                _kodPocztowy = value;
            }
        }

        public string Miasto
        {
            get
            {
                return _miasto;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Błędna wartość pola Miasto");
                _miasto = value;
            }
        }

        public string Ulica
        {
            get
            {
                return _ulica;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Błędna wartość pola Ulica");
                _ulica = value;
            }
        }

        public int NrDomu
        {
            get
            {
                return _nrDomu;
            }
            set
            {
                if (_nrDomu > 0)
                    throw new Exception("Błędna wartość pola NrDomu");
                _nrDomu = value;
            }
        }

        public int NrMieszkania
        {
            get
            {
                return _nrMieszkania;
            }
            set
            {
                if (_nrMieszkania > 0)
                    throw new Exception("Błędna wartość pola NrMieszkania");
                _nrMieszkania = value;
            }
        }

        public Adres()
        {
            _kodPocztowy = string.Empty;
            _miasto = string.Empty;
            _ulica = string.Empty;
            _nrDomu = 0;
            _nrMieszkania = 0;
        }

        public override string ToString()
        {
            string formattedAddress = "";

            if (!string.IsNullOrEmpty(_kodPocztowy))
                formattedAddress += $"{_kodPocztowy} ";

            if (!string.IsNullOrEmpty(_miasto))
                formattedAddress += $"{_miasto} ";

            if (!string.IsNullOrEmpty(_ulica))
                formattedAddress += $"{_ulica} ";

            if (_nrDomu > 0)
                formattedAddress += $"{_nrDomu}";

            if (_nrDomu > 0 && _nrMieszkania > 0)
                formattedAddress += $"/{_nrMieszkania}";

            return $"Dane adresowe = {formattedAddress}";
        }
    }
}
