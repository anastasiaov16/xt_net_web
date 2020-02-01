var input = document.getElementById('text');
var btn = document.getElementById('but');
btn.addEventListener('click', deleteWords);


function deleteWords(){
    var str = input.value;
    var separator = ["?", "!", ":", ";", ",", ".", " ", "\t"];
    var arr = str.split(''), letters = {}, start = 0, words = [], result = "";
    arr.forEach(function (letter, i) {
        if (separator.indexOf(letter) != -1) {
            words.push(str.substr(start, i - start));
            start = i + 1;
        }
    });
    words.push(str.substr(start));
    
    words.forEach(function (word) {
        word.split('').forEach(function (letter, i) {
            if (!letters[letter] && word.indexOf(letter, i + 1) != -1) {
                letters[letter] = 1;
            }
        });
    });
    
    arr.forEach(function(let, i){
        if(letters[let] != 1){
            result += let;
        }
    });
    alert(result);
}
