class Reference {
    private string _chapter;
   
    private string _book;

    private int _start_verse;

    private int _end_verse;

    public Reference (string chapter, string book, int start_verse){
        _chapter = chapter;
        _book = book;
        _start_verse = start_verse;
    }

    public Reference (string chapter, string book, int start_verse, int end_verse){
        _chapter = chapter;
        _book = book;
        _start_verse = start_verse;
        _end_verse = end_verse;
    }

    public void Display(){
        if (_end_verse == 0){
            Console.WriteLine($"{_book} {_chapter}:{_start_verse}");
        } 
        else{
            Console.WriteLine($"{_book} {_chapter}:{_start_verse}-{_end_verse}");
        }
    }
}