using System;
using System.Collections.Generic;
using System.Text;

namespace KursSelenium.Tasks
{
    class Task5_potomkowie
    {
        //Trzy zadania:
        //1. nowosci fuertavertura "dodaj do koszyka"
        //2. Kategoria windsurfing "domyślne sortowanie"
        //3. Dodać coś do koszyka - przejść do koszyka - "cena w górnym naglówku"

        //Ad1.
        //    section[aria-label = "Najnowsze Produkty"] a[data-product_id="393"]
        //    section.storefront-recent-products a[data - product_id = "393"]
        //Ad2.
        //    header.woocommerce-products-header+div.storefront-sorting select.orderby
        //    header.woocommerce-products-header+div select  <-- szukamy najpierw headera ktorej jedną z klas bedzie .woocommerce-products-header zaznacz mi pierwszego brata takiego kóry jest divem i który ma w sobie selecta i wez zaznacz tego selecta
        //Ad3.
        //    a.cart-contents>.woocommerce-Price-amount
    }
}
