using System;
using System.Collections.Generic;
using System.Text;

namespace KursSelenium.Tasks
{
    class Task6_Xpath_atrybuty_tagi_tekst
    {
        Source: https://fakestore.testelka.pl/zamowienie/

            1. Lokalizacja pierwszej zamówionej pozycji
            .//*[contains(text(), 'Wspinaczka Via Ferraty')]
            

            2. Lokalizacja drugiej zamówionej pozycji
            .//*[contains(text(), 'Wspinaczka Island Peak')]
            
            3. Lokalizacja checkboxa
            .//input[@type='checkbox' and @name='createaccount']
            .//*[@id='createaccount']   

            4. Zaznaczenie dwóch pól dotyczących adresu (Ulica i ciąg dalszy)
            .//input[contains(@autocomplete, 'address-line')]
            .//input[starts-with(@id, 'billing_address_')]
    }
}
