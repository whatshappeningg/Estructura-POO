# Estructura POO
## Introducción
Este proyecto es un modelo de estructura de programación orientada a objetos especificando clases, atributos, propiedades y métodos, donde los objetos se referencian entre sí.  
Para conseguir el enunciado se le ha dado a ChatGPT el siguiente prompt:  
> Quiero que me crees una propuesta de estructura POO, que yo implementaré en unity, dime las clases que hay, que atributos tienen, publicas y privadas. Alguno de los objetos debería referenciar a objetos de otro tipo. Como pasa en un inventario con los objetos de tipo item. Haz una propuesta de ejemplo, que no sea de inventario, relacionada con videojuegos, lo más original y divertida que puedas. Sencillo: , de 3 clases maximo y dos o tres atributos por clase.

El resultado fue una propuesta sobre una carrera de caracoles mutantes. Entonces, se especificó una temática de piratas. A la respuesta obtenida se le implementaron algunas modificaciones para que la práctica tuviera más cohesión. ([Link](https://chatgpt.com/share/69384b66-71bc-8011-b944-f886f19db95c) a la conversación).  

## Clases  
### Arma  
Cuenta con propiedades como el nombre o el daño que inflige, y el atributo de la durabilidad, que va disminuyendo a medida que este arma es utilizada por un pirata.  
### Pirata  
Esta clase se relaciona con la clase "Arma", siendo un equipable del pirata e influyendo en su fortaleza total. También tiene otros atributos como la cantidad de monedas de oro, que se actualiza cada vez que se reclama un botín.  
### Isla  
Las islas almacenan una lista de todos los piratas que se encuentran en ella, enfrentándolos entre ellos y entregando el botín al pirata más fuerte. Cuando el botín ya ha sido reclamado la isla queda inaccesible.
