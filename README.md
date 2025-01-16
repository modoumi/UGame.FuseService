# 公共服务项目

## 公共服务列表

1. [x]  Email - 邮箱
2. [x]  Notify - 消息提醒
3. [x]  Promoter - 分销推广
4. [x]  Plugins.Banner - 广告图
5. [x]  Plugins.Marquee - 跑马灯



## 结构约定

> 简约项目

````
-- Email （解决方案文件夹及目录结构文件夹）
 | -- SComms.Email.API
    | -- Annotations （注解：需则加）
    | -- Judgments   （断言-底层支持：需则加）
    | -- Repositories (数据持久)
    | -- Services     (业务逻辑)
    | -- Common       (公共方法)
    | -- Consumers    (消费端)
    | -- Events      （包含 IntegrationEvents）
    | -- Models       (request、response、枚举、常量、结构等定义)
       | -- Ipos
       | -- Dtos
       | -- Enums
          | -- EmailEnums.cs
    | -- Caching     （缓存）
       | -- DCache
       | -- DbCache
    | -- Extensions   (扩展)
    | -- EmailController.cs
    | -- EmailStartup.cs

  
````

> 插件项目

````
-- Plugins （目录结构文件夹）
 | -- SComms.Plugins.Banner
    | -- Annotations （注解：需则加）
    | -- Judgments   （断言-底层支持：需则加）
    | -- Repositories (数据持久)
    | -- Services     (业务逻辑)
    | -- Common       (公共方法)
    | -- Consumers    (消费端)
    | -- Events      （包含 IntegrationEvents）
    | -- Models       (request、response、枚举、常量、结构等定义)
       | -- Ipos
       | -- Dtos
       | -- Enums
          | -- BannerEnums.cs
    | -- Caching     （缓存）
       | -- DCache
       | -- DbCache
    | -- Extensions   (扩展)
    | -- BannerController.cs
    | -- BannerStartup.cs

  
````

