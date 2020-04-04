# Delegate

In questa soluzione sono presenti tre progetti:

- Delegate
- DelegateGenerici
- DelegateMulticast
- DelegateAction
- DelegateFunc

Un delegate è un tipo riferimento usato per incapsulare un metodo.
La dichiarazione di un tipo delegato è simile alla firma di un metodo. Ha un valore restituito e una serie di parametri di qualsiasi tipo:

```
public delegate void TestDelegate(string message);
public delegate int TestDelegate(MyType m, long num);
```

Nel progetto DelegateGenerici è stato fatto uso dei tipi generici per passare gli argomenti al delegate.

Nel progetto DelegateMulticast è stato fatto uso del multicast per assegnare ad una sola istanza del delegate l'esecuzione di più metodi.

Nel progetto DelegateAction si osserva il comportamento di "Action", un delegate che non ritorna nulla, è un tipo predefinito e come dice la parola stessa si tratta di un'azione, quindi la funzione non ritorna un risultato, ma void.

Nel progetto DelegateFunc si osserva il comportamento di "Func", un delegate che a differenza di Action ritorna un risultato. Viene solitamente usato per eseguire una funzione/azione che deve ritornare un risultato.

Nel progetto DelegateFunc-LambdaExpression si osserva il comportamento di "Func" associato all'uso di una Lambda Expression, vedi "operatore lambda" (=>).
