import { sum } from "./sum.js";
import {expect} from 'chai'; 

describe('sum', () => {
   
    it('should return 0 if an empty array is given', ()=>{
        //Arrnage
        const empty=[];
        //Act
        const result=sum(empty);
        //Assert
        expect(result).to.equals(0);
    })
    it ('should return a single number if an array with single number is given', ()=>{
        //Arrnage
        const single=[23];
        //Act
        const result=sum(single);
        //Assert
        expect(result).to.equals(23);
    })
    it('should return the correct sum if a correct array is given', ()=>{
        //Arrnage
        const array=[23,5,18];
        //Act
        const result=sum(array);
        //Assert
        expect(result).to.equals(46);
    })
    it ('should return correct sum if an array with numbers as string is given', ()=>{
         //Arrnage
         const array=["23","5","18"];
         //Act
         const result=sum(array);
         //Assert
         expect(result).to.equals(46);
    } )

})



