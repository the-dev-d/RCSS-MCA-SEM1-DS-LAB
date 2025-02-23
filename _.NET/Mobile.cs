//create a class called mobile in C#, class should have following attributes or methods. 
// fields are brand, model, battery lvel.
// methods are MakeCall(phoneno), ChargeBattery(amount), useBattery(amount), printMobile()

// After creating the class, create an instance of Mobile class, set branch and model, call chargeBattery to charge up to 50%.
// Call makeCall() method to simulate making a calll.
// Call useBattery() method to simulate battery usage.
// print details of mobile using print details method.

using System;

namespace MobileClasses {

    interface ICamera {
        void TakePhoto();
    }

    interface IGps {
        void GetLocation();
    }
    class Mobile {

        public Mobile(string brand, string model) {
            this.brand = brand;
            this.model = model;
        }
        private string brand;

        public Mobile() {
            this.battery = 0;
        }

        public string Brand {
            get { return brand; }
            set { brand = value; }
        }

        private string model;
        public string Model {
            get { return model; }
            set { model = value; }
        }

        private short battery;
        public short Battery {
            get { return battery; }
        }

        public void MakeCall(string phone) {
            Console.WriteLine("Calling "+ phone + " ...");
        }

        public void ChargeBattery(short amount) {
            if(this.battery + amount > 100) {
                Console.WriteLine("Battery full");
                this.battery = 100;
                return;
            }
            battery+=amount;
        }

        public void useBattery(short amount) {
            if(this.battery - amount < 0) {
                Console.WriteLine("Battery down");
                this.battery = 0;
                return;
            }
            this.battery-=amount;
        }

        public void PrintDetails() {
            Console.WriteLine("Brand: " + this.brand);
            Console.WriteLine("Model: " + this.model);
            Console.WriteLine("Battery at " + this.battery + "%");
        }

    }
}