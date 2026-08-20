# Laboratorio-1
## Prácticas 1 al 3 
Reglas que use para poder programar las funciones de cada panel:  

  1.Usar C# Windows Forms (.NET Framework).
  
  2.Mantener los nombres y la estructura solicitada por la profesora.
  
  3.Utilizar nombres descriptivos para los controles:
  
    - lbl → Label
    - txt → TextBox
    - btn → Button
    - rdb → RadioButton
    
  4.Los nombres deben indicar claramente la función del control.
  
    - txtNombre
    - txtVenta
    - lblResultado
    - btnCalcular
    
  5.Utilizar MessageBox.Show() para mostrar mensajes al usuario cuando sea necesario.
  
  6.Para validar campos vacíos, utilizar: string.IsNullOrWhiteSpace().
  
  7.Para cantidades monetarias utilizar decimal, ya que la guía recomienda este tipo para evitar problemas de precisión con valores financieros.
  
  8.Cada Practica se tiene que seguir una estructura para el nombre de cada panel al ser ejecutado.
  
### Practica N1 - Controles
Se debían agregar los controles necesarios, incluyendo Labels, tres TextBox y dos botones. Cada control debía tener un nombre de acuerdo con la nomenclatura indicada, utilizando txt para los TextBox, lbl para los Labels y btn para los botones.
El botón Mostrar debía verificar que los campos de texto no estuvieran vacíos y, posteriormente, mostrar la información solicitada en el Label correspondiente. Por otro lado, el botón Finalizar debía mostrar primero el mensaje "Se cerrará la ventana", después "Cerrando" y finalmente cerrar la ventana. También se debía organizar y dar formato a los controles de acuerdo con el diseño indicado en la guía.

### Practica N2 - Descuentos
El programa debía aplicar las siguientes reglas:  

-Si la venta era mayor o igual a $500, se aplicaba un 30 % de descuento.

-Si la venta era mayor de $300 y menor o igual a $499, se aplicaba un 20 % de descuento.

-Si la venta era mayor de $100 y menor o igual a $299, se aplicaba un 10 % de descuento.

-Si la venta era menor o igual a $100, no se aplicaba ningún descuento.


Además, el programa debía mostrar el porcentaje de descuento, el monto del descuento aplicado y el valor final de la venta. Para los controles se debía utilizar la nomenclatura adecuada, como lbl, btn y txt.
La práctica también incluía el uso del tipo de dato decimal para trabajar con valores monetarios y la validación de los datos introducidos por el usuario.

### Practica N3 - Estructura if

El objetivo era elaborar un formulario que permitiera al usuario realizar diferentes operaciones mediante botones de acción. La operación que debía ejecutarse tenía que cambiar dependiendo del RadioButton seleccionado por el usuario.
Para desarrollar esta práctica se debían aplicar los conocimientos vistos anteriormente, especialmente el uso de estructuras if, validación de datos, controles de Windows Forms y operadores lógicos. La guía señala expresamente que se debían tener en cuenta las consideraciones de las prácticas anteriores.
