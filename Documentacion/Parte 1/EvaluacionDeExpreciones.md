# Evaluacion de expreciones

## Planteamiento
Sin usar el computador, evalúe las siguientes expresiones, y para cada una de ellas indique el resultado y su tipo (si la expresión es válida) o qué error ocurre (si no lo es):

``` c#
>>> 2 + 3      // (Ejemplo) Respuesta: Tipo int, valor 5
>>> 4 / 0      // (Ejemplo) Respuesta: Error de división por cero

>>> 5 + 3 * 2
>>> '5' + '3' * 2
>>> 2 ** 10 == 1000 or 2 ** 7 == 100
>>> int("cuarenta")
>>> 70/16 + 100/24
>>> 200 + 19%
>>> 3 < (1024 % 10) < 6
>>> 'six' + 'eight'
>>> 'six' * 'eight'
>>> float(-int('5') + int('10'))
>>> abs(len('ocho') - len('cinco'))
>>> bool(14) or bool(-20)
```

Compruebe sus respuestas en el computador.

## Solucion

``` c#
>>> 2 + 3                               // (Ejemplo) Respuesta: Tipo int, valor 5
>>> 4 / 0                               // (Ejemplo) Respuesta: Error de división por cero

>>> 5 + 3 * 2                           // Respuesta: Tipo int, valor 11
>>> '5' + '3' * 2                       // Respuesta: Error de tipo de dato
>>> 2 ** 10 == 1000 or 2 ** 7 == 100    // Respuesta: Operador "**" no valido en C#
>>> int("cuarenta")                     // Respuesta: No se puede convertir de string a int
>>> 70/16 + 100/24                      // Respuesta: Tipo int, valor 8
>>> 200 + 19%                           // Respuesta: Error de tipo de dato
>>> 3 < (1024 % 10) < 6                 // Respuesta: Tipo bool, valor True
>>> 'six' + 'eight'                     // Respuesta: No se puede convertir de char a string
>>> 'six' * 'eight'                     // Respuesta: No se puede convertir de char a string, operador "*" no valido para cadenas
>>> float(-int('5') + int('10'))        // Respuesta: Error de tipo de dato
>>> abs(len('ocho') - len('cinco'))     // Respuesta: Error de tipo de dato
>>> bool(14) or bool(-20)               
```