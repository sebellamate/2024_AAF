
function solveQuadratic(a, b, c) {
    const D = b*b - 4*a*c;
    if (D < 0) {
        return {};
    } else if (D === 0) {
        return {x: -b/(2*a)};
    } else {
        return {
            x1: (-b-Math.sqrt(D))/(2*a),
            x2: (-b+Math.sqrt(D))/(2*a)
        };
    }
}

const A = {x: 0, y: 0};
const B = {x: 3, y: 4};
const C = {x: 11, y: 10};
const D = {x: -9, y: -1};

function distance(A, B) {
    const elso = Math.pow((A.x - B.x), 2);
    const masodik = Math.pow((A.y - B.y), 2)
    const gyokalatti = elso + masodik;
    return Math.sqrt(gyokalatti);
}

// a [0, 1[ intervallumon ad random valós számot
// Math.random()

// [0, 1[ * 5 => [0, 5[
// parseInt([0, 5[) => 0, 1, 2, 3, 4

// rand(5) => 1, 2, 3, 4, 5
// parseInt(Math.random()*5) + 1

// rand(n): 1-tól n-ig ad egy random egészet
function rand(n) {
    return parseInt(Math.random()*n)+1
}

// 0, 1, 2, 3, 4 => 3, 4, 5, 6, 7
// [a..b] intervallumon random egész
function randint(a, b) {
    
}
const points = [
    {x: 1, y: -1},
    {x: 4, y: 0},
    {x: 5, y: 3},
    {x: 3, y: 4},
    {x: -1, y: 2}
];

function perimeter(points) {
    let s = 0;
    for (let i = 0; i < points.length-1; i++) {
        s += distance(points[i], points[i+1]);
    }
    s += distance(points[points.length-1], points[0]);
    return s;
}