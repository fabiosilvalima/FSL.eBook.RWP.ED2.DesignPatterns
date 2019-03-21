using System.Web.Mvc;

namespace FSL.eBook.RWP.ED2.DesignPatterns.FacadeChapter
{
    public sealed class FacadeController : 
        Controller
    {
        public ActionResult WithoutFacade()
        {
            var logger = new Logger();
            var payment = new Payment();
            var securityInfo = new SecurityInfo();
            var transaction = new Trasaction();

            logger.Log("Payment Start");
            var result = false;
            var userId = "3434343";
            var securityId = securityInfo.GetFromUserId(userId);
            logger.Log($"Security id {securityId} for user id {userId}");
            transaction.Start();
            transaction.Do(() =>
            {
                var amount = 45.400;
                result = payment.Pay(securityId, amount);
                logger.Log($"Paying {amount} for security id {securityId}");
            });
            transaction.End();
            logger.Log("transaction end");
            logger.Log($"payment result {result}");
            
            return Content("WithoutFacade");
        }

        public ActionResult WithFacade()
        {
            var facade = new Facade();
            var result = facade.Pay("3434343", 45.400);

            return Content("WithFacade");
        }
    }
}