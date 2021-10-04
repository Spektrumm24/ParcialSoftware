1. El programa desarrollado se trata de un pequeño juego de un guerrero que tiene dos armas, las cuales puede intercambiar
utilizando la Z y puede atacar utilizando el SPACE, un arco y una espada. el guerrero tiene frente a si un conejo que
puede matar con su arco. El programa pretende resolver el cambio de armas en un videojuego y el ahorro de memoria en la
creacion de objeto cuya vida util sea corta pero se use constantemente como la munición.

2. El primer patrón usado fue Strategy.
a) Se utilizó este patrón ya que se requería que el jugador pudiera utilizar varias armas con comportamientos distintos
entre ellas. Asi que se escogio el patron Strategy porque con este se puede crear la logica de la espada y la del arco
en clases separadas y se hace uso de una interface para poder unirlas al jugador como si fueran un solo objeto tipo
Weapon, asi que al jugador no le interesa especificamente si está usando un arco o una espada, solo que está usando un
arma y con esta puede atacar.
b) La interface utilizada se puede evidenciar en el Script Weapon.cs con una sola acción Attack(), luego en los archivos
Bow.cs y Sword.cs se encuentran las dos estrategias cada una implementando la interface Weapon con su método Attack(),
linea 10 a 19 en Bow.cs y linea 11 a 14 en Sword.cs (el ataque de la espada se evidencia en la consola con un mensaje
que dice "Espadazo!"). Luego en el archivo Player.cs desde la linea 17 a 23 se encuentra el metodo Attack() del jugador
donde simplemente tiene un arma que ejecuta el método de Attack de esa arma, independientemente de cual sea y desde la
linea 24 a 27 se encuentra el método SetWeapon() donde se inyecta la estrategia del arma.
Finalmente en el archivo Manager.cs donde desde la linea 16 a la 21 se encuentra el método de Unity llamado Awake() 
donde se instancia el jugador, se obtiene el arma y se le inyecta esa arma al jugador.

3. El segundo patrón utilizado fue Object Pool
a) Se utilizó este patrón ya que se requeria que el arco que usa el jugador pudiera disparar varias flechas. Asi que se
escogió el patrón de Object Pool para reducir el consumo de memoria del juego al crear y destruir objetos de Flecha una
y otra vez, entonces utilizando un Pool de una cierta cantidad de flechas de forma predeterminada se pueden reducir el 
consumo facilmente.
b) El uso del patrón se evidencia mayormente en el archivo ObjectPool.cs donde se crea una lista de tipo GameObject
(linea 9) y la cantidad de objetos que se quiere poner en el pool (linea 10) luego en el método Start() de Unity
se crea un ForLoop donde se 'llena' el pool con GameObject's de flecha y se dejan inactivos (linea 21 a 26). Luego 
en un metodo llamado GetPooledObject() se crea un ForLoop que revisa si hay objetos inactivos en la herarquía y los retorna
(linea 30 a 37).
Luego en el archivo Bow.cs se reemplaza la creacion de flechas antigua (linea 12) por la de ObjectPool donde se crea un
GameObject al que se le asigna el objeto que devuelve el método GetPooledObject() del ObjectPool y luego se revisa si no
es nulo para si hacer que se active en la herarquía (linea 14 a 18). Finalmete en el archivo Arrow.cs, cuando se detecta la
colision de la flecha, en vez de destruirla, se inactiva en la herarquía para poder reutilizarla nuevamente (linea 23 a 27).
