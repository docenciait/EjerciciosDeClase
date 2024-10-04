# Lambdas

Las lambdas en C# se escriben usando la sintaxis:

```
(parametros) => expresión;

```

**Sintaxis y estructura**

Parámetros: Van entre paréntesis. Si no hay parámetros, se usa (). Si hay un solo parámetro y su tipo puede inferirse, no es necesario incluir los paréntesis ni el tipo.
Operador lambda (=>): Separa los parámetros del cuerpo de la función.

Expresión o bloque: Es el cuerpo de la lambda. Puede ser una única expresión (devuelve automáticamente el resultado) o un bloque de código { ... }.

Ejemplos

- Lambda sencilla con un solo parámetro:

```
int[] numbers = { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(n => n % 2 == 0); 
// Filtra números pares. "n" es el parámetro, y la expresión "n % 2 == 0" es el cuerpo de la lambda.

```

- Lambda con varios parámetros:

```
Func<int, int, int> sum = (a, b) => a + b;
int result = sum(3, 4);  // Resultado: 7

```

- Lambda con bloque de código:

```
Action<string> greet = name => {
    string greeting = $"Hello, {name}!";
    Console.WriteLine(greeting);
};
greet("Iván"); // Imprime: Hello, Iván!

```
