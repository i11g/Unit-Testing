import {rgbToHexColor } from "./rgbToHexColor.js"
import{expect} from "chai"

describe('rgbToHexColor', () =>{
    it('should return the correct color if the correct RGB numbers are given',()=>{
        //Arrange
        const red=132;
        const green=216;
        const blue=65;
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.equal("#84D841")

    })
    it('shoudl return undefined if red is of invalid type', ()=> {
        //Arrange
        const red="132";
        const green=216;
        const blue=65;
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.undefined
    })
    it('shoudl return undefined if green is of invalid type', ()=> {
        //Arrange
        const red=132;
        const green="216";
        const blue=65;
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.undefined
    })
    it('shoudl return undefined if blue is of invalid type', ()=> {
        //Arrange
        const red=132;
        const green=216;
        const blue="65";
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.undefined
    })
    it('shoudl return undefined if red is not in the expected range', ()=> {
        //Arrange
        const red=-1;
        const green=216;
        const blue=65;
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.undefined
    })
    it('shoudl return undefined if green is not in the expected range', ()=> {
        //Arrange
        const red=132;
        const green=-1;
        const blue=65;
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.undefined
    })
    it('shoudl return undefined if blue is not in the expected range', ()=> {
        //Arrange
        const red=132;
        const green=216;
        const blue=-1;
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.undefined
    })
    it('shoudl return undefined if red is not in the expected range', ()=> {
        //Arrange
        const red=256;
        const green=216;
        const blue=65;
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.undefined
    })
    it('shoudl return undefined if green is not in the expected range', ()=> {
        //Arrange
        const red=132;
        const green=256;
        const blue=65;
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.undefined
    })
    it('shoudl return undefined if green is not in the expected range', ()=> {
        //Arrange
        const red=132;
        const green=216;
        const blue=256;
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.undefined
    })
    it('shoudl return undefined if all is not in the expected range', ()=> {
        //Arrange
        const red=-1;
        const green=-1;
        const blue=-1;
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.undefined
    })
    it('shoudl return undefined if all is not in the expected range', ()=> {
        //Arrange
        const red=256;
        const green=256;
        const blue=256;
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.undefined
    })
    it('shoudl return correct if all is in the expected range', ()=> {
        //Arrange
        const red=0;
        const green=0;
        const blue=0;
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.equal('#000000')
    })
    it('shoudl return undefined if all is not in the expected range', ()=> {
        //Arrange
        const red="256";
        const green="256";
        const blue="256";
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.undefined
    })
    it('shoudl return undefined if all is not in the expected range', ()=> {
        //Arrange
        const red=132;
        const green="256";
        const blue="256";
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.undefined
    })
    it('shoudl return correct if all is in the expected range', ()=> {
        //Arrange
        const red=255;
        const green=255;
        const blue=255;
        
        //Act
        const result=rgbToHexColor(red,green,blue);
        //Assert
        expect(result).to.be.equal('#FFFFFF')
    })
})