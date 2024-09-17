using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial
{
    // 1 = define a delegate (contract between publisher and consumer)
    // 2 = define a event based on the delegate
    // 3 = publish/raise an event 

    

    public class VideoEncoder
    {
         // 1 = define a delegate (contract between publisher and consumer)
    //  first parameter = source of the event / class that publish or sending the event
    //  second parameter = EventArgs args = any aditional data that we want to send through the event
    // this method determine the signature of subscriber
        public delegate void VideoEncodedEventHandler(object source,EventArgs args);

     // 2 = define a event based on the delegate 
    //  create event
        public event VideoEncodedEventHandler VideoEncoded;

   
        public void Encoder(Video video){
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            OnvideoEncoded();
        }

         // 3 = publish/raise an event 
    // in .Net event publisher method should be protected virtual and void method name will start with on
        protected virtual void OnvideoEncoded(){
            if(VideoEncoded != null){
                VideoEncoded(this,EventArgs.Empty);
            }
        }
    }
}