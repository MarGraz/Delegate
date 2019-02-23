# Delegate

In questa soluzione sono presenti tre progetti:

- Delegate
- DelegateGenerici
- DelegateMulticast

Un delegate è un tipo riferimento usato per incapsulare un metodo.
La dichiarazione di un tipo delegato è simile alla firma di un metodo. Ha un valore restituito e una serie di parametri di qualsiasi tipo:

```
public delegate void TestDelegate(string message);
public delegate int TestDelegate(MyType m, long num);
```

Nel progetto DelegateGenerici è stato fatto uso dei tipi generici per passare gli argomenti al delegate.

Nel progetto DelegateMulticast è stato fatto uso del multicast per assegnare ad una sola istanza del delegate l'esecuzione di più metodi.
