//console.log('from file!');

function mymethod(x, y, z) {
    if (typeof x !== "undefined") {
        console.log('x has value');
    }
    if (typeof y !== "undefined") {
        console.log('y has value');
    }
    if (typeof z !== "undefined") {
        console.log('z has value');
    }
    a = 10;
    console.log(`inside method ${a}`);

    //return 10;
    //10;
}

var result = mymethod('john');
console.log(typeof result);

console.log(`outside method ${a}`);

for (let i = 0; i < 10; i++) {
    let k = i;
}

//console.log(k);
//console.log(i);

console.log("-------------------------");


//var names = new Array();
var names = ['C#'];
console.log(typeof names);
console.log(Array.isArray(names));
console.log(names instanceof Array);
console.log(names.length);
console.log(names[0]);
names[1] = "Java";
names.push("Python");
names.push("Perl");
names.push("PHP");
names.push("JS");

console.log(names.pop());
console.log(names.shift());

names.unshift("C++");
names.sort();


names.splice(2, 0, "VB.NET");

console.log("------------------");
for (var i = 0; i < names.length; i++) {
    console.log(names[i]);
}
console.log("------------------");

for (let ix in names) {
    console.log(`[${ix}] : ${names[ix]}`);
}
console.log("------------------");

for (let name of names) {
    console.log(`${name}`);
}
console.log("------------------");

console.log(names.join(','));
