export class paivakirja {
    constructor() {
        this.entryLits = document.querySelector('.entry');
    }
    async initpage_paivakirja() {
        console.log('initpage_paivakirja started');
        try {
            const response = await fetch('../api/fetchExercise.php');
            if (!response.ok) {
                console.error('HTTP error', response.status, response.statusText);
                throw new Error('Network response was not ok');
            }
            const data = await response.json();  // or response.text(), depending on what your PHP returns
            console.log(data);
        } catch (error) {
            console.error('Fetch error:', error);
        }
    }

}