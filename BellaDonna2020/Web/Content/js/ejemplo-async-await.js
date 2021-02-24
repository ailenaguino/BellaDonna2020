const fabricaDePromesas = indice =>
    new Promise((resolve, reject) => {
        const tiempoRejected = Math.floor(Math.random() * 10000) + 1000;
        const tiempoResolved = Math.floor(Math.random() * 10000) + 1000;

        setTimeout(() => {
            reject(`la promesa ${indice} falló`);
        }, tiempoRejected);

        setTimeout(() => {
            resolve(`promesa ${indice} satisfecha`);
        }, tiempoResolved);
    });



/* Promise.allSettled(misPromesas)
    .then(respuesta => console.log(respuesta))
    .catch(razon => console.log(razon)); */



async function miAsyncFunction() {
    try {
        let misPromesas = [];
        for (let i = 0; i < 10; i++) {
            misPromesas.push(await fabricaDePromesas(i));
        }
        console.log('variable misPromesas al interior de la async function', misPromesas);
        return misPromesas;

        //const miPromesa1 = await fabricaDePromesas(1);
        //console.log('valor de miPromesa1', { miPromesa1 });
        //return miPromesa1;
    } catch (error) {
        //console.log('hubo un error');
        //return error;
        throw error;
    }
};
function miFunction() {
    return fabricaDePromesas(2);
    /* const miPromesa2 = fabricaDePromesas(2)
        .then(resultado => console.log(resultado))
        .catch(razon => console.log(razon)); */
};
