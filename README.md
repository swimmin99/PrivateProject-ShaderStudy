<div align="center">
  
![header](https://capsule-render.vercel.app/api?type=waving&height=250&color=auto&text=Shader%20Study&fontColor=auto)
![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=UNITY&fontColor=000000&fontSize=20)
![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=2022.1.20~&fontColor=000000&fontSize=15)
  
<div align="left">

```
  π  μ΅μ’ λͺ©ν : μμ΄λ κ·Έλνλ₯Ό μ¬μ©νμ¬ μ€κ° λμΉλ λ¬Όκ²°μΉλ νλλ₯Ό κ΅¬ν
  βοΈ  μ ν : κ°μΈ νλ‘μ νΈ
  βοΈ  μ¬μ© κΈ°μ  : C#, μ λν° URP λ λ νμ΄νλΌμΈ
  π‘  κΈ°λ : μμ΄λμ λλ΅μ μΈ μ¬μ©λ² μ΄ν΄, λΆλ ₯μ μ½λλ‘ ννν΄λ³΄κΈ°
  π  μμ μ₯μ  μμ : μμ΄λ κ·Έλν μ¬μ©λ² μ§μμ λΆμ‘±, μ°Έκ³ μλ£μ μ€λͺ λΆμ‘±
 
  Objective : Create immersive realistic wave using URP shader graph with unity
  Private Project, using C# and Unity URP Rendere Pipeline
  Might be able to understand brief techniques of how to use shader graph and express buyoancy with C# script/
  Might bump in to obstacles due to lack of understanding of shadergraph or struggle from lack of explanation in tutorials.
```
  
<div align="center">
<br>
  
  ![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=DEV%20SCHEDULE&fontColor=000000&fontSize=15)

  
 
|λ μ§|μ°¨μ|λ‘κ·Έ|μ°Έκ³ μλ£(Credits)|μ½λ|
|---|---------|---------|----|-----|
|2023-01-21|1-1|waterPhysics| [shaderManipulation1](https://catlikecoding.com/unity/tutorials/flow/waves/) <br> [meshManipulation](https://www.youtube.com/watch?v=_Ij24zRI9J0) <br> [buoyancy](https://www.youtube.com/watch?v=iasDPyC0QOg&t=496s)|[WaterShaderGraph](https://github.com/swimmin99/PrivateProject-ShaderStudy/blob/main/UnbendedWater%201.shadergraph) <br> [OceanManager C#](https://github.com/swimmin99/PrivateProject-ShaderStudy/blob/main/OceanManager.cs)|
|2022-01-28|1 - 2|FoamShader and Texture Redone|[FoamShader1](https://www.youtube.com/watch?v=MHdDUqJHJxM&t=464s) <br> [FoamShader2](https://www.youtube.com/watch?v=MHdDUqJHJxM&t=464s)||
|2022-01-29|1 - 3|PlayerController||[OceanFollow(C#)](https://github.com/swimmin99/PrivateProject-ShaderStudy/blob/main/OceanPlayerFollow.cs) <br> [PlayerMove](https://github.com/swimmin99/PrivateProject-ShaderStudy/blob/main/PlayerMove.cs)|
|2023-01-30|1 - 4|DepthMask&&BoatController|[DepthMask](https://web.archive.org/web/20210831213650/http://wiki.unity3d.com:80/index.php/DepthMask)||
|2023-01-31|2|Orthographic Camera|[Orthographic Depth Calc](https://twitter.com/cyanilux/status/1169932943869059073?lang=en)||
|2023-02-01|3|Bending Shader|[Curved World Shader Shader Graph](https://www.youtube.com/watch?v=UoK7VRs3tfo) <br> [World Bending](https://www.youtube.com/watch?v=SOK3Ias5Nk0&t=87s)|[BendedWaterShaderGraph](https://github.com/swimmin99/PrivateProject-ShaderStudy/blob/main/BendedWater.shadergraph)|
 
  
  <br>
  
  ![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=DEV%20LOG&fontColor=000000&fontSize=15)

  
---
</div>
<div align="left">

<u><strong>μμ΄λ μ€ν°λ1 (Shader Study 1)</strong></u>
  

```
πλͺ©ν : μμ΄λ κ·Έλνλ₯Ό μ¬μ©νμ¬ λ¬Όκ²°μΉλ νλλ₯Ό κ΅¬ν.
μΈλΆλͺ©ν1 : λ©μ¬λ₯Ό λ³κ²½μν€μ§ μκ³  μμ΄λλ‘ νκ³ λ₯Ό κ΅¬νν  κ².
μΈλΆλͺ©ν2 : λΆλ ₯μ μ¬μ©ν  μ μλλ‘ vertex λμ΄ λ³νλ₯Ό μ λ¬ ν  μ μλλ‘ ν  κ².
μΈλΆλͺ©ν3 : λ¬Ό μμ λ¬ λ¬Όμ²΄μ κ²½μ° Foam(κ±°ν)μ΄ μκΈ°λ ν¨κ³Όλ₯Ό μμ΄λλ‘ κ΅¬νν  κ².
```

  
<div align="center">
  <img src ="https://user-images.githubusercontent.com/109887066/216982077-fa823f73-ac51-4242-a5da-9ad5355b239b.png" width="70%" height="70%"/>
  
```μλ1 : λ¬Όκ²°μ κ·Έλν½ μ μΈ λΆλΆλ§ κ΅¬νν λͺ¨μ΅```
  
  <img src ="https://user-images.githubusercontent.com/109887066/216984447-1218c658-899c-43d6-a8f1-da94ce68766d.gif" width="30%" height="30%"/>

  ```μλ2 : κ°λ¨ν λ¬Όμ²΄ λΆλ ₯ νμ€νΈ```
  
   <img src ="https://user-images.githubusercontent.com/109887066/216985735-af88be11-deac-480f-b3f4-d9ce75399afd.gif" width="30%" height="30%"/>

  ```μλ3 : λ¬Όμ²΄μ λ¬Όμ μ κΈ΄ λΆλΆμ Foam ν¨κ³Όλ₯Ό μΆκ°ν λͺ¨μ΅```<br> 
    <img src ="https://user-images.githubusercontent.com/109887066/216986154-96ab24ec-b816-4c5e-b422-b5679df2e338.gif" width="35%" height="35%"/>

  ```μλ4 : λ¬Ό μμμ μ΄λνλ λ¬Όμ²΄```
  
  <img src ="https://user-images.githubusercontent.com/109887066/216976847-f30eba03-0895-40c4-95e7-8a940ff507a2.png"  width="70%" height="70%"/>

  ```μμ±λ μμ΄λ κ·Έλν```

<div align="left">


```
π‘λ°μ ν μ 
1.μ λν°μ μμ΄λ κ·Έλνμ λλ΅μ μΈ μ¬μ©λ²κ³Ό μ€ν¬λ¦½νΈλ‘ μ°λνλ λ²μ λ°°μ.
2.κ΅³μ΄ μ€ν¬λ¦½νΈλ₯Ό μμ±νμ§ μμλ λΈλλ₯Ό ν΅ν΄ μ½κ² κ΅¬νμ΄ κ°λ₯νλ€λ κ²μ κΉ¨λ¬μ.

πμμΌλ‘μ λ°©ν₯
1.μμ΄λ κ·Έλνλ₯Ό μμ μμ¬λ‘ μ¬μ©ν  μ μλλ‘ λ€μν μμ΄λλ₯Ό κ΅¬νν΄λ³Έλ€.
2.μ°Έκ³  μλ£μ μμ§νλ μ λλ₯Ό μ€μ¬ λλ§μ κ°μ± μλ μμ΄λλ₯Ό λ§λ€μ΄λ³Έλ€.
```
  

---
</div>
<div align="left">

<u><strong>μμ΄λ μ€ν°λ2 (Shader Study 2)</strong></u>

```
πλͺ©ν : Orthographic μΉ΄λ©λΌ λ·°μμ μ¬μ©κ°λ₯ν λ¬Ό μμ΄λλ₯Ό λ§λ λ€.
μΈλΆλͺ©ν : ScreenDepthλ₯Ό Perspective View μΉ΄λ©λΌμ λμΌνκ² μ¬μ©ν  μ μκΈ°μ μλ‘μ΄ λ°©λ²μ μ°Ύλλ€.
```
   <div align="center"> 
   <img src ="https://user-images.githubusercontent.com/109887066/216987145-ad6f8b6f-9550-489a-8632-56ac7d76f387.gif" width="40%" height="40%"/>  

  ```Orthographic Camera Viewλ‘ κ΅¬νν λ¬Ό μμ΄λ```


  <img src ="https://user-images.githubusercontent.com/109887066/216978543-a39f7c5b-b95e-4b9c-b4de-ea2ee5afd1db.png"  width="75%" height="75%"/>
     
 ```μμ±λ μμ΄λ κ·Έλνμ λͺ¨μ΅```

 <div align="left">
   
  ```
π‘λ°μ ν μ 
1.Viewμ λ°λΌ λ€λ₯΄κ² κ³μ°λλ Depthλ₯Ό μ΄μ©νλ λ°©λ²μ μκ² λ¨.
2.Perspectiveμ λ¬λ¦¬ Orthographic Viewλ λνΉν λ§νΌ μ¬λ¬κ°μ§ μ λ‘μ¬ν­μ΄ λ§λ€λ κ²μ μκ² λ¨.
  
πμμΌλ‘μ λ°©ν₯
1.μμ§ μμ΄λμ λν μ΄ν΄κ° λΆμ‘±ν κ²μΌλ‘ λκ»΄μ§. μΈλΆ λΈλλ€μ κΈ°λ₯κ³Ό μ°μμμ λν΄ λμ± κΉκ² νμ΅ν΄μΌ ν¨.
2.Orthographic μΉ΄λ©λΌ λ·°λ₯Ό μ¬μ©ν  λλ μ¬μ μ κ·Έλν½ μμλ₯Ό μ΄λ»κ² κ΅¬νν μ§ μΈλΆμ μΌλ‘ κ³νν΄μΌκ² λ€κ³  μκ° ν¨.
 ```
  
---
---
 </div>
<div align="left">
<u><strong>μμ΄λ μ€ν°λ3 (Shader Study 3)</strong></u>

```
πλͺ©ν : World Bending ν¨κ³Όλ₯Ό μ£Όμ΄ μ§νμ μΌλ‘ λ€κ°κ°μλ‘ μλλ‘ νλ ν¨κ³Όλ₯Ό μ€λ€.
μΈλΆλͺ©ν1 : μΌλ° μ€λΈμ νΈμ μ μ© κ°λ₯ν μμ΄λλ₯Ό λ§λ λ€.
μΈλΆλͺ©ν2 : ν΄λΉ κ·Έλνλ₯Ό μλΈ κ·Έλνν μν¨λ€.
μΈλΆλͺ©ν3 : ν΄λΉ κ·Έλνλ₯Ό μ΄μ μ κ΅¬νν λ¬Ό μμ΄λμ ν©μ²΄ μν¨λ€.
```
   <div align="center"> 
   <img src ="https://user-images.githubusercontent.com/109887066/216990234-f97ea8c3-3393-466a-8230-92a43c8b6b5e.gif" width="40%" height="40%"/>  

  ```World Bending ν¨κ³Όλ₯Ό μΆκ°ν λ¬Ό μμ΄λ```


  <img src ="https://user-images.githubusercontent.com/109887066/216978837-42eaeabc-e0a7-4ec7-ba0a-6e453aeee2c9.png"  width="75%" height="75%"/>
     
  ```μ°Έκ³ ν μ μΆμ² : [Youtube](https://www.youtube.com/watch?v=UoK7VRs3tfo)```

  <img src ="https://user-images.githubusercontent.com/109887066/216978984-044a594c-4673-4d5f-ba70-865357b4ff41.png"  width="75%" height="75%"/>

  ```μ΅μ’ μμ΄λ κ·Έλν```

     
<div align="left">
  
```
π‘λ°μ ν μ 
1.μ΄μ  λ³΄λ€ μμ΄λ κ·Έλνμ μΈλΆ λΈλμ λν μ΄ν΄λκ° μ¦κ°ν¨.
2.Importν 3D λͺ¨λΈμ΄ FBX νμμΌ κ²½μ°μ materialκ³Ό textureμ λ°λ‘ Extract νμ¬ μμ΄λλ₯Ό μ μ©ν΄μΌ νλ€λ μ¬μ€μ λ°°μ.
πμμΌλ‘μ λ°©ν₯
1.Shader Graphλ₯Ό μ¬μ©νλ λ€λ₯Έ Shaderμ μλ‘μ΄ Shaderλ₯Ό ν©μΉλ λ°©μμ μ΄ν΄νμμΌλ 
  ν©μΉλ €λ μμ΄λμ μ’λ₯κ° λ€λ₯Έ κ²½μ° (URP Lit Shader/Legacy Surface Shader/HDRP Shader)μΌ κ²½μ°μλ μ΄λ €μ. 
  μ΄μ λν μλ£λ₯Ό λ μ°Ύμλ³Ό κ².
```
  
  
  WORK IN PROGRESS~
---

    
```
π‘λλμ  : μ λν°κ° μ κ³΅νλ URP μμ΄λ κ·Έλνλ μ€λ‘ κ°λ ₯ν ν΄μ΄λ€. 
  κ·Έλ¬λ λΌμ΄νκ³Ό λ¬Όλ¦¬ λ²μΉλ€μ μμ΄λλ‘ κ΅¬ννκΈ° μν΄μλ μνμ λν μ§μμ λ μμμΌ ν  κ²μΌλ‘ λ³΄μΈλ€. 
  λν λΆλ ₯μ νννκΈ° μν΄ μ¬μ©νμλ μ€ν¬λ¦½νΈλ₯Ό μλ²½νκ² μνν΄ λΈ κ² κ°μ§ μλ€. 
  λ°λΌμ ν΄λΉ λΆλΆμ λ³΅μ΅νκ³  λμ μλ§λλ‘ κ³ μΉλ©΄μ μΉν΄μ§ νμκ° μλ€. 
  λ°°μ λ¬Όμ΄ μ°¨λ κ²μ λ°©μ§νλ Depth Maskμ κ²½μ° μΌλ° Viewλ μ μ©μμΌ°μ§λ§ World Bending λ¬Ό μμ΄λμ μ μ©μν€μ§ λͺ»νμλ€. 
  ν΄λΉ λ¬Έμ λ₯Ό ν΄κ²°νκΈ° μν΄μλ μμ΄λ κ·Έλνλ₯Ό μ¬μ©νμ§ μκ³  μ€ν¬λ¦½νΈλ₯Ό ν΅ν΄ μμ΄λλ₯Ό μ μ©μν€λ λ² λν λ°°μμΌ ν  κ²μΌλ‘ λ³΄μΈλ€.
  
  λν μμ§ λͺκ°μ§ λ¬Έμ κ° ν΄κ²°λμ§ μμκΈ°μ μΆν νλ‘μ νΈμ μκ°μ λ ν¬μν΄ μμ±ν΄ λκ°μΌ ν  κ²μΌλ‘ λ³΄μΈλ€.
  
  Overall : URP Shader Graph is a powerful tool for creating a realistic 3d effects.
  However lighting and Physics part demands deeper understanding in math.
  Thus, haven't fully comprehended buyoancy script (FloatingObjects C#) yet.
  Haven't figure out how to combine bended water shader with depth mask shader since its based on totally different shader.
  
  λ€μ μ€ν : 3D κ·Έλν½κ³Ό κ΄λ ¨λ μν μμ  μ½κΈ°, μ€ν¬λ¦½νΈ μλ³΄κΈ°
  Next step would be peeping through math lecture and books in library and review my scripts and work more on shader.
```
  

