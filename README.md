# II-Brujula-Acelerometro-GPS

## Objetivo
El objetivo de esta práctica es la utilización de diferentes componentes del móvil para que puedan aplicarse a los proyectos. La utilización de estos componentes viene dada por la clase Input de Unity3D.
El objetivo de la práctica de esta semana consiste en utilizar los componentes más sencillos del móvil.
Estos son:
• Brújula
• Acelerómetro
• GPS
Como norma general, para la utilización de estos componentes se debe importar el paquete UnityEngine y, haciendo uso del mismo, obtener los datos de los mismos a través de la clase Input. Hay que tener en cuenta que al probarse en el ordenador, muchos de los componentes pueden devolver datos no realistas o directamente no funcionar.

## Brújula
Proporciona la orientación del dispositivo respecto al Polo Norte, dada por el atributo de tipo float Input.compass.trueHeading. Para poder usar este valor es necesario activar la localización del dispositivo, llamando a la función Input.location.Start().

## Acelerómetro
Obtiene la posición relativa en el espacio del dispositivo, en coordenadas X, Y y Z. Viene dada por el atributo de tipo Vector3 Input.acceleration.

## GPS
Obtiene las coordenadas del dispositivo, en latitud, longitud y altitud, como atributos del objeto
Input.location.lastData.
• Input.location.lastData.latitude
• Input.location.lastData.longitude
• Input.location.lastData.altitude
Estos atributos sólo se actualizan una vez realizada la llamada a Input.location.Start() (también usada para obtener datos de la brújula). Esta función tiene dos argumentos opcionales: la precisión deseada y la distancia mínima de actualización (ambas en metros y por defecto 10). Conviene comprobar el valor del atributo Input.location.status, que indica si el servicio está activo (LocationServiceStatus.Running), antes de leer Input.location.lastData.
Una vez termine de usarse el servicio de localización, debe detenerse con una llamada a la función Input.location.Stop().

## Qué se pide
Para la realización de esta práctica, se pide una de estas 2 opciones:
• Crear al menos una pantalla para probar cada uno de los elementos dados.
• Utilizar alguno de los elementos dados en el proyecto final. 
