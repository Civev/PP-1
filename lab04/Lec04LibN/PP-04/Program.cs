using Lec04LibN;

ILogger logger = Logger.createLogger();

logger.start("A");
logger.log("333333");
logger.start("B");

logger.log("2123");


ILogger logger2 = Logger.createLogger();
logger.start("C");
logger2.log("1111");
logger2.stop();
logger2.log("1111");
logger2.stop();
logger.stop();
logger2.log("1111");
