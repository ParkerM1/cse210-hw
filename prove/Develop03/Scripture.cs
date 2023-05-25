class Scripture {
    private string _scripture;

    private  List<Word> _words = new List<Word>();

    public Scripture (Reference reference, string text){
        string[] words = text.Split(" ");
        foreach (var w in words){
            var word_obj = new Word(w);
            _words.Add(word_obj);
        }
    }


    public void Hide_word(){
        for (int i = 0; i < 3; i++){
            int legnth = _words.Count(); 
            Random randomGenerator = new Random();
            int vaule_random = randomGenerator.Next(legnth);
            _words[vaule_random].Hide();
        }
    }

    public void Display(){
        foreach(Word i in _words ){
            Console.Write($"{i.Get_text()} ");
        }
    }

    // public Boolean All_hidden(){
    //     int count = 0;
    //     int len = _words.Count();
    //     foreach (Word i in _words);
    //         if (i == "_"){
    //             count += 1;
    //         }
    //     if (count == len){
    //         return true;
    //     }
    //     else
    //     {
    //         return false;
    //     }
    // }
}