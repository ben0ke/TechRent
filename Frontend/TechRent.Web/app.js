document.getElementById('loadBtn').addEventListener('click', async () => {
    const container = document.getElementById('deviceContainer');
    container.innerHTML = '<p>Töltés...</p>';

    try {
        // Cseréld ki a portot a saját API portodra!
        const response = await fetch('https://localhost:7275/api/devices');
        const devices = await response.json();

        container.innerHTML = '';
        devices.forEach(dev => {
            container.innerHTML += `
                <div class="card">
                    <h3>${dev.megnevezes}</h3>
                    <p>Kategória: ${dev.kategoria}</p>
                    <p>Állapot: <span class="status">${dev.allapot}</span></p>
                    <button onclick="alert('Kölcsönzési igény leadva: ${dev.id}')">Kölcsönzés</button>
                </div>
            `;
        });
    } catch (error) {
        container.innerHTML = '<p style="color:red;">Hiba az API elérésekor.</p>';
        console.error(error);
    }
});