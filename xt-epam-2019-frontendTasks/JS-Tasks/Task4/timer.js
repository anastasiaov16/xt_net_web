var pause = false;
(function start() {
    var timer = document.getElementById("timer");
    var time = timer.innerHTML;
    if (time == 0) {
        tmp = setTimeout(goToNext,100);
        return;
    }
    else{
        if (!pause) {
            timer.innerHTML = time - 1;
        }
    }
    setTimeout(start, 1000);
}());

var next = document.getElementById("next");
next.onclick = function next() {
    if(document.title == "Page1"){
        window.location.href = "../page2/htmlfile.html"
    }
    if(document.title == "Page2"){
        window.location.href = "../page3/htmlfile.html"
    }
    if(document.title == "Page3"){
        window.location.href = "../page4/htmlfile.html"
    }
}

var previous = document.getElementById("previous");
previous.onclick = function previous() {
    if(document.title == "Page2"){
        window.location.href = "../page1/htmlfile.html"
    }
    if(document.title == "Page3"){
        window.location.href = "../page2/htmlfile.html"
    }
    if(document.title == "Page4"){
        window.location.href = "../page3/htmlfile.html"
    }
}

var stop = document.getElementById("stop");
stop.onclick = function StopTimer() {
    pause = true;
}

var start = document.getElementById("start");
start.onclick = function StartTimer() {
    pause = false;
}