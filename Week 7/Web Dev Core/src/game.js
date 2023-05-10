var title = "My Balloon Game";
//hoisting is the difference between var and let
let developer = "Ahmed Idris";

const BALLOON_TOTAL = 20;

//The values in the arrays can change, but "balloons" 
//must stay array
const balloons = [];

let score = 0;

//JS objects are declared directly. Class not needed


function greeting(){
    let gameTitleText = `${title} - by ${developer}`
    let gameTitle = document.getElementById("game-title");
    gameTitle.innerHTML = gameTitleText
}

testBalloon.move = function(){
    this.x += 10;
}
function setup() {
    //creates canvas object and attaches it to specified container
    let canvas = createCanvas(640, 480)
    canvas.parent("game-container")
   
    for(let i = 0; i < BALLOON_TOTAL; i++){
    balloons.push(new Balloon(
    random(width), 
    random(height), 
    33,
    color(random(255), random(255), random(255))))
    }
}
    
function draw() {
    //a nice sky blue background
    background(135, 206, 235)

    for(let balloon of balloons){
        balloon.blowAway()
        balloon.checkToPop()
        
    fill(balloon.col)
    circle(balloon.x, balloon.y, balloon.r)

    }


}

function youWin(){
    noLoop()

    let para = document.createElement("p")
    para.style.fontSize = "64px";

    let textNode = document.createTextNode("You win!")
    para.appendChild(textNode)

    document.getElementById("game-container").appendChild(para)

}
  