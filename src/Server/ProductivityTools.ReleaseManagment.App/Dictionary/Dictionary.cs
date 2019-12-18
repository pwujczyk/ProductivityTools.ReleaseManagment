using ProductivityTools.ReleaseManagment.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductivityTools.ReleaseManagment.App
{
    public class Dictionary : IDictionary
    {
        private readonly EcoVadisTMContext EcoVadisTMContext;

        public Dictionary(EcoVadisTMContext ecoVadisTMContext)
        {
            EcoVadisTMContext = ecoVadisTMContext;
        }

        public int GetDVId(string dictionaryName,string dictValueKey)
        {
            DictValue value=EcoVadisTMContext.DictValue.SingleOrDefault(x => x.Dictionary.Name == dictionaryName && x.Key == dictValueKey);
            if (value==null)
            {
                throw new Exception("Missing DictValue item");
            }
            else
            {
                return value.DictValueId;
            }
        }

        public int GetDictionaryId(string dictionaryName)
        {
            EF.Dictionary dictionary = EcoVadisTMContext.Dictionary.SingleOrDefault(x => x.Name == dictionaryName);
            if (dictionary==null)
            {
                throw new Exception("Missing dictionary item");
            }
            else
            {
                return dictionary.DictionaryId;
            }

        }
    }
}
