import {sum } from './sum.js';
import{expect} from 'chai';

describe('sum', ()=> {

    it('should return 0 if an empty array is given', ()=>{

        //Arrange 
        const emptyArray=[];

        //Act
        const result=sum(emptyArray);
        //Assert
        expect(result).to.equals(0);        

    })

})
