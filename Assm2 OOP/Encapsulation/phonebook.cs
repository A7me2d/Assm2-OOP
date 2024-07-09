using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm2_OOP.Encapsulation
{
    internal struct phonebook
    {
        string[] Names;
        int[] Numbers;
        int size;


        #region Properties
        public int Size
        {
            get { return size; }
        }
        #endregion

        #region Constru
        public phonebook(int _size)
        {
            size = _size;
            Names = new string[size];
            Numbers = new int[size];
        }

        #endregion


        #region Methods

        public void AddPerson(int Postion, string name, int Number)
        {
            if (Numbers is not null && Names.Length > 0)
            {
                Names[Postion] = name;
                Numbers[Postion] = Number;
            }


        }

        #region Getter Seetter
        public int GetNumber(string name)
        {
            if (Names is not null && Numbers is not null) {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    if (Names[i] == name)
                    {
                        return Numbers[i];
                    }
                }
            }
            return -1;


        }



        public void SetPersonNubmer(string name, int newNumbers) {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Names[i] == name)
                    {
                        Numbers[i] = newNumbers;
                    }
                }
            }
        }
        #endregion


        #endregion


        #region Index
        public int this[string name]
            {
            get {
            if(Names is not null && Numbers is not null)
                
                    for(int i = 0;i < Names.Length; i++)
                    
                        if(Names[i] == name)
                            return Numbers[i];
                        return -1;
                    
                
            }
            set
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Names.Length; i++)
                    {
                        if (Names[i] == name)
                             Numbers[i] = value;
                        break;                        
                    }
                }

            }
            }


        public string this[int index] {
            get { return $"{index} :: {Names[index]} :: { Numbers[index]}"; }
        }
        #endregion

    }
}
