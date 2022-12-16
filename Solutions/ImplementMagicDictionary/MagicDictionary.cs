namespace ImplementMagicDictionary
{
    using System.Collections.Generic;
    using System.Linq;

    //This class is a data structure that allows users to build a dictionary of words and efficiently search for words that are similar to a given search word
    public class MagicDictionary
    {
        private readonly List<string> _words = new List<string>();
    
        public MagicDictionary()
        {}
    
        //This method is used to build the dictionary of words. It takes an array of strings as input,
        //representing the words to be added to the dictionary
        public void BuildDict(string[] dictionary) {
            foreach(var word in dictionary) this._words.Add(word);
        }
    
        //This method is used to search for a word in the dictionary that is similar
        //to the given `searchWord`. It returns true if a word is found similar to the `searchWord`, and false otherwise 
        
        //NOTE: A word is considered similar to the `searchWord` if it has the same length as the `searchWord` ad differs by only one character
        public bool Search(string searchWord)
        {
            foreach (var x in this._words)
            {
                if(x.Length != searchWord.Length) continue;
            
                var count = x.Where((t, j) => t == searchWord[j]).Count();

                if(count == searchWord.Length-1) return true;
            }

            return false;
        }
    }
}