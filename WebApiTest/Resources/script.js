const url = "https://localhost:44322/text/calculate";

function sendCalculateRequest(name1, name2) {

    const fullUrl = `${url}?name1=${name1}&name2=${name2}`;
    fetch(fullUrl, {
            //mode: "no-cors",
            method: "GET"
        }).then(response => response.text())
        .then(txt => {
            console.log(txt);
            setOutput(txt);
        });
}

function setOutput(result) {

    const output = document.querySelector("#output");

    output.textContent = result;
}

function calculate() {
    const name1 = document.querySelector("#name1").value;
    const name2 = document.querySelector("#name2").value;

    sendCalculateRequest(name1, name2);
}