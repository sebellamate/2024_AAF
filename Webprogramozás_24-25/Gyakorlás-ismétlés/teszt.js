const products = [
    {
        name: "Televízió",
        price: 80000,
        category: "Elektronika"
    },
    {
        name: "Hűtőszekrény",
        price: 120000,
        category: "Háztartási gépek"
    },
    {
        name: "Mosógép",
        price: 100000,
        category: "Háztartási gépek"
    },
    {
        name: "Laptop",
        price: 150000,
        category: "Elektronika"
    },
    {
        name: "Kávéfőző",
        price: 25000,
        category: "Konyhai eszközök"
    }
];

function minkivalasztas() {
    let index = 0;
    let legkisebb = products[0].price;
    for (let i = 0; i < products.length; i++) {
        if (products[i].price < legkisebb) {
            legkisebb = products[i].price
            index = i;
        }
    }
    console.log("Legolcsóbb termék: " + products[index].name + " (" + products[index].category + ")");
}

minkivalasztas();


function countABPairs(betuk) {
    let parok = 0;
    for(let i = 0; i < betuk.length-1; i++){
        if(betuk[i] === "a" && betuk[i+1] === "b"){
            parok += 1
        }
    }
    console.log("countABPairs("+betuk+") === " + parok);
}

countABPairs("abba");

function hatvany(a,k){
    const eredeti = k;
    if(k<0){
        k = k *(-1);
    }
    let c = 1;
    for(let i = 0; i < k; i++){
        c = c * a;
    }

    if (k < 0) {
        console.log("Negatív kitevő");
        c = 1 / c;
    }

    return c;
}

function atvalt(n){
    let maradek = "";
    while(n != 0){
        m = n % 2;
        n = parseInt(n/2);
        maradek = m + maradek;
    }
    return parseInt(maradek);
}

function hasonlit(a,b){
    if (a<b) {
        return -1;
    }
    else if(b<a){
        return 1;
    }
    else return 0;
}
