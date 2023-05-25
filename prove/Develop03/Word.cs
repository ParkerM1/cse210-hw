class Word{
    private string _letters;

    private bool _isHidden;

public Word (string letters) {
    _letters = letters;
    _isHidden = false;
}

    public void Hide() {
        _isHidden = true;
    }

    public void Unhide(){
        _isHidden = false;
    }

    public string Get_text(){
        if (_isHidden){
            string underscores = "";
            int num_letters = _letters.Length;
            for (int i = 0; i < num_letters; i++){
                underscores += "_";
            }

            return underscores;
        }
        else{
            return _letters;
        }
    }
}