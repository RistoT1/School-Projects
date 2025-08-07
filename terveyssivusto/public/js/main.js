import { paivakirja } from './paivakirja.js';

document.addEventListener('DOMContentLoaded', () =>{
    const body = document.body;
    console.log("loaded");
    
    if(body.classList.contains('page-paivakirja')){
        console.log("loading")
        const diary = new paivakirja();   
        diary.initpage_paivakirja(); 
    }
})