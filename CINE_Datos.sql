USE CINE
GO

--DATOS DIRECTORES

EXEC usp_CrearDirector 'Polanski', 'Roman', 'Francia', '19330818'
EXEC usp_CrearDirector 'Romero', 'George A.', 'Estados Unidos', '19480116'
EXEC usp_CrearDirector 'Carpenter', 'John', 'Estados Unidos', '19480116'
EXEC usp_CrearDirector 'Corman', 'Roger', 'Estados Unidos', '19260405'
GO

--DATOS PELICULAS

EXEC usp_CrearPelicula 1, 'Bitter Moon', 'Drama', 'Durante una traves�a en un transatl�ntico, una pareja brit�nica formada por el aburrido Nigel y su esposa, coinciden con Oscar, un americano parapl�jico, y su atractiva e inquietante mujer, Mimi.', '19920712'
EXEC usp_CrearPelicula 1, 'Rosemarys Baby', 'Terror', 'Un matrimonio se instala en un apartamento de Nueva York sin sospechar que sus vecinos pertenecen a una secta sat�nica. Cuando Rosemary queda embarazada, se a�sla poco a poco y la verdad sobre su beb� es revelada despu�s de tenerlo.', '19680612'
EXEC usp_CrearPelicula 1, 'The Ninth Gate', 'Suspenso', 'Un comerciante de libros raros es contratado por un adinerado coleccionista para hallar dos tomos cuyo autor es Satan�s.', '20000622'
EXEC usp_CrearPelicula 1, 'The Pianist', 'Drama', 'Un jud�o polaco, pianista profesional, lucha por la supervivencia en Varsovia frente a la invasi�n nazi. Despu�s de, gracias a unos amigos, haber evitado la deportaci�n, el pianista debe vivir oculto y constantemente expuesto al peligro.', '20030508'

EXEC usp_CrearPelicula 2, 'Night of the living dead', 'Terror', 'Luego de un accidente radioactivo, tres personas se ocultan en una casa de varios cad�veres carn�voros.', '19681001'
EXEC usp_CrearPelicula 2, 'Dawn of the Dead', 'Terror', 'Cuatro personas reforzan un centro comercial abandonado y se enfrentan a un ej�rcito de zombies carn�voros.', '19780901'
EXEC usp_CrearPelicula 2, 'Day of the Dead', 'Terror', 'Atrapado en un silo de misiles, un peque�o equipo de cient�ficos, civiles y soldados lucha para asegurar la supervivencia de la raza humana, pero la tensi�n est� alcanzando el punto de ruptura y los zombis se est�n reagrupando afuera.', '19850719'

EXEC usp_CrearPelicula 3, 'The Thing', 'Terror', 'Un alien�gena que se transforma en otras formas vivientes, invade una base cient�fica de la Ant�rtida.', '19820625'
EXEC usp_CrearPelicula 3, 'Halloween', 'Terror/Suspenso', 'Un mani�tico regresa a su ciudad natal para continuar con la plaga de terror que inici� hace quince a�os.', '19781025'
EXEC usp_CrearPelicula 3, 'John Carpenters Vampires', 'Terror/Accion', 'Jack Crow se hizo cazador de vampiros cuando estos mataron a sus padres. Ahora, y con la ayuda de la Iglesia Cat�lica y de un grupo de mercenarios, se enfrenta en el desierto de Nuevo M�xico a Jan Valek, el jefe de la banda de muertos vivientes m�s poderosa del mundo.', '19981030'

EXEC usp_CrearPelicula 4, 'Pit and the Pendulum', 'Terror/Drama', 'Un plan para enloquecer a un hombre sale al rev�s cuando �ste adopta la s�dica personalidad de su padre fallecido.', '19610712'
EXEC usp_CrearPelicula 4, 'The Tomb Of Ligeia', 'Terror/Drama', 'El fantasma celoso de una mujer atormenta a su marido y su nueva esposa en esta adaptaci�n de la historia de Allan Poe.', '19641101'
EXEC usp_CrearPelicula 4, 'The Raven', 'Comedia de terror', 'Tres brujos se envuelven en una extra�a lucha por el poder, en esta adaptaci�n del poema cl�sico de Edgar Allan Poe.', '19630125'

SELECT * FROM DIRECTOR
GO

SELECT * FROM PELICULA
GO