using System;

namespace BookstoreModel
{
    [Serializable]
    public class CD:Item
    {

        private uint songNumber;
        private string publisher;


        public CD(string title, string author, uint songNumber, string publisher, decimal price)
            :base(title, author, price)
        {
            this.songNumber = songNumber;
            this.publisher = publisher;
        }

        public override decimal CalculateGrossPrice()
        {
            return price + CalculateTax();
        }

        public override void UpdatePrice(decimal rate)
        {
            if (this.songNumber > 5)
            {
                this.price = this.price * rate;
            }
        }
        public override void UpdatePrice()
        {
            this.price = price + price * 0.05M;
        }

        public override decimal CalculateTax()
        {
            return price * 0.23M;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", title, author, songNumber, publisher, price);
        }
    }

    /*
     * efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
    efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
    efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ
efqwgef;qwhjijfl;awkjrfikqjwref
     * qwfqwlieejfoqwlkejflqwkeef
     * dfcashdckasjjjjjjjjjjjjjjaaahowiehfwjdclkasmsmsc
     * adcl wjehfdk sadjcnwqlefeckfnw
     * effc wkefcfjhwskdcjhwqffc
     * s'eefasdvasdvasrvqewrvujhacvv
     *  edjdjhufwofijsc
     *      aedejhAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIKEFHWLVWVERRBEQ



    */



}
