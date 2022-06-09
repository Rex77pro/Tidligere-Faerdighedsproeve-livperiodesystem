using System;
using System.Collections.Generic;
using System.Text;

namespace Tidligere_Færdighedsprøve_livperiodesystem
{
    class Aktivitet
    {
        public int _id;
        public int _minAlder;
        public int _maxAlder;
        public DateTime _startPunkt;
        public DateTime _slutPunkt; 

        public Aktivitet(int iD, int minAlder, int maxAlder, DateTime startPunkt, DateTime slutPunkt)
        {
            _id = iD;

            //if (minAlder > maxAlder)
            //{
            //    throw new ArgumentException($"{minAlder} skal være mindre end {maxAlder}");
            //}

            _minAlder = minAlder;
            _maxAlder = maxAlder;

            //if (startPunkt > slutPunkt)
            //{
            //    throw new ArgumentException($"Start tidspunktet: {startPunkt}, skal være før slut tidspunkt: {slutPunkt}");
            //}

            _startPunkt = startPunkt;
            _slutPunkt = slutPunkt;
        }

        public int ID { get { return _id; } set { _id = value; } }

        public int MinAlder 
        {
            get
            {
                if (_minAlder > _maxAlder)
                {
                    Console.WriteLine("Aktivitet blev ikke tilføjet");
                    throw new ArgumentException($"Id {_id} | Minimumsalderen: {_minAlder} skal være mindre end maksimumalderen: {_maxAlder}");
                }
                else 
                {
                    return _minAlder;
                }
            } 
            set { _minAlder = value; } 
        }
        public int MaxAlder { get { return _maxAlder; } set { _maxAlder = value; } }

        public DateTime StartTidsPunkt {
            get
            {
                if (_startPunkt > _slutPunkt)
                {
                    Console.WriteLine("Aktivitet blev ikke tilføjet");
                    throw new ArgumentException($"Id: {_id} | Starttidspunktet: {_startPunkt}, skal være før sluttidspunktet: {_slutPunkt}");
                }
                else
                {
                    return _startPunkt;
                }
            } 
            set { _startPunkt = value; } 
        }
        public DateTime SlutTidsPunkt { get { return _slutPunkt; } set { _slutPunkt = value; } }

        public override string ToString()
        {
            return $"ID: {ID} | Aldersgrænse {MinAlder} - {MaxAlder} år | Starter: {StartTidsPunkt}, Slutter: {SlutTidsPunkt.TimeOfDay}";
        }
    }
}
