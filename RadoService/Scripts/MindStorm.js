
(function () {

    'use strict';
    var card1 = null;
    var card2 = null;

    function hideCard(card) {
        card.id = card.id - "card";
    }

    function checking() {
        if (card1.id == card2.id) {
            var replacer = document.createElement('div');
            replacer.className = 'replacer';
            var replacer2 = document.createElement('div');
            replacer2.className = 'replacer';
            document.getElementById(card1.id).parentNode.replaceChild(replacer, document.getElementById(card1.id));
            document.getElementById(card2.id).parentNode.replaceChild(replacer2, document.getElementById(card2.id));
            card1 = null;
            card2 = null;
        }
        else {
            hideCard(card1);
            hideCard(card2);
            card1 = null;
            card2 = null;
        }
    }

    // var value = document.getElementById("input").value;
    function cardCreate() {
        var wrapperDiv = document.createElement('div');

        for (var i = 0; i < 13; i++) {
            var divInner = document.createElement('div');
            divInner.className = 'randomDiv';
            divInner.id = i;
            wrapperDiv.appendChild(divInner);

            divInner.onclick = function () {
                if (card1 != null) {
                    if (card2 != null) {
                        //Third click
                        checking();
                    } else {
                        showCard(this);
                        card2 = this;
                    }
                } else {
                    showCard(this);
                    card1 = this;
                }
            }
        }
        
        document.getElementById("renderHere").appendChild(wrapperDiv);
    }
    cardCreate();
    cardCreate();


    function showCard(card) {
        card.id = "card" + card.id;
    }

})();