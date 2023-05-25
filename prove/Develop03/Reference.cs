class Reference {
    private string _chapter;
   
    private string _book;

    private int _startVerse;

    private int _endVerse;

    public Reference (string chapter, string book, int start_verse){
        _chapter = chapter;
        _book = book;
        _startVerse = start_verse;
    }

    public Reference (string chapter, string book, int start_verse, int end_verse){
        _chapter = chapter;
        _book = book;
        _startVerse = start_verse;
        _endVerse = end_verse;
    }

    public void Display(){
        if (_endVerse == 0){
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}");
        } 
        else{
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
        }
    }
}