using System;


namespace RemotingSystem
{
    interface IRemote
    {
        void PowerOn();
        void PowerOff();
        void IncreaseVolume();
        void ChangeChannel(int channelNumber);
    }

    interface IRemotePrice
    {
        string getPriceDetails();
    }

    interface IRemoteLocationDetails
    {
        string getLocation();
    }

    class SonyRemote : IRemote, IRemotePrice
    {
        public void ChangeChannel(int channelNumber)
        {
            Console.WriteLine($"Sony TV changed to channel {channelNumber}.");
        }

        public void IncreaseVolume()
        {

            Console.WriteLine("Sony TV volume increased.");
        }

        public void PowerOff()
        {
            Console.WriteLine("Sony TV is now Off.");
        }

        public void PowerOn()
        {
            Console.WriteLine("Sony TV is now ON.");
        }


        public void A()
        {

        }

        public void B()
        {

        }

        public void C()
        {

        }

        public string getPriceDetails()
        {
            return "500Rupees";
            //throw new NotImplementedException();
        }


        //public void asfjalsfvakjskfasfaskjd()
        //{

        //}
    }


    class LGRemote : IRemote, IRemoteLocationDetails
    {
        public void ChangeChannel(int channerlNumber)
        {
            Console.WriteLine($"LG TV changed to channel {channerlNumber}.");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("LG TV volume increased.");
        }

        public void PowerOff()
        {
            Console.WriteLine("LG TV is now Off.");
        }

        public void PowerOn()
        {
            Console.WriteLine("LG TV is now On.");
        }

        public string getLocation()
        {
            return "Bengolore";
        }
        
    }

    class Program3
    {
        static void Main()
        {
            //SonyRemote sr = new SonyRemote();
            //sr.
            // or 
            IRemote remote = new SonyRemote();
            remote.PowerOn();
            remote.PowerOff();
            remote.IncreaseVolume();
            remote.ChangeChannel(10);
            
            IRemotePrice priceRemote = new SonyRemote();
            string priceDetails = priceRemote.getPriceDetails();
            Console.WriteLine(priceDetails);


            IRemote lgremote = new LGRemote();
            lgremote.PowerOn();
            lgremote.PowerOff();
            lgremote.IncreaseVolume();
            lgremote.ChangeChannel(10);

            IRemoteLocationDetails remotePricedetails = new LGRemote();
            string loctionDetails = remotePricedetails.getLocation();
            Console.WriteLine(loctionDetails);







            //remote.A();


        }
    }

}
