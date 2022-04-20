## Teddy Hotel
### ความเป็นมาของโปรแกรม
จารย์สั่ง

<br/><br/>
### วัตถุประสงค์ของโปรแกรม
ทำเอาคะแนน

<br/><br/>
### โครงสร้างของโปรแกรม
```mermaid
classDiagram
    Program <|-- SneakerShop
    SneakerShop <|-- AllStar
    SneakerShop <|-- ChuckTaylor
    SneakerShop <|-- JackPurcell
    SneakerShop <|-- OneStar
    Program : +Main()
    class SneakerShop{
        +openToolStripMenuItem_Click()
        +saveToolStripMenuItem_Click()
        +buttonConfrim_Click()
        +buttonBuy_Click()
        +buttonClear_Click()
        +buttonCheck_Click()
    }
    class AllStar{
        +AllStarWhite()
        +AllStarRed()
        +AllStarBlack()
        +AllStarGray()
        +AllStarBlue()
    }
    class ChuckTaylor{
        +ChuckTaylorPink()
        +ChuckTaylorGreen()
        +ChuckTaylorWhite()
        +ChuckTaylorRed()
        +ChuckTaylorBlack()
    }
    class JackPurcell{
        +JackPurcellNavyBlue()
        +JackPurcellWhite()
    }
    class OneStar{
        +OneStarMustard()
        +OneStarBlack()
        +OneStarOliveGreen()
    }
```
<br/><br/>
### ผู้พัฒนาโปรแกรม
