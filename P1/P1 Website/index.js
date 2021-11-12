function buy(product) {
    let cart = document.querySelector('#cart tbody');
    let newItem = cart.insertRow();

    let itemName = newItem.insertCell(0);
    itemName.innerHTML = product;


    let elementId = '#'+product.replace(' ', '');
    
    let itemPrice = newItem.insertCell(1);
    itemPrice.innerHTML = document.querySelector(elementId +' .price').innerHTML;

    
    let itemQuantity = newItem.insertCell(2);
    itemQuantity.innerHTML = document.querySelector(elementId +' td .quantity').value;

    document.querySelector(elementId +' td .quantity').value = '';


}



function checkout()
    {
        document.querySelectorAll('#cart tbody tr').forEach(row => row.remove());
    }

