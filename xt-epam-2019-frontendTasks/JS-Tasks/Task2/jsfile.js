var input = document.getElementById('text');
var btn = document.getElementById('but');
btn.addEventListener('click', calculate);

function calculate(){
    var str = input.value;
    var result;
    str = str.split(/([*,/,+,-,=])/);
    for (var i = 0; i <= str.length - 1; i++) {

        if (str[i] === '*') {
            str[i + 1] = parseFloat(str[i - 1]) * parseFloat(str[i + 1]);
            result = str[i + 1];
        }
        
        if (str[i] === '/') {
            str[i + 1] = parseFloat(str[i - 1]) / parseFloat(str[i + 1]);
            result = str[i + 1];
        }
       
        if (str[i] === '+') {
            str[i + 1] = parseFloat(str[i - 1]) + parseFloat(str[i + 1]);
            result = str[i + 1];
        }
        if (str[i] === '-') {
            str[i + 1] = parseFloat(str[i - 1]) - parseFloat(str[i + 1]);
            result = str[i + 1];
        }

        if(str[i] === '='){
            alert(result);
        } 
    }
}