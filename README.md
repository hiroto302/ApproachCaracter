# 作品名 : ApproachCaracter
VRアプリ　オキュラスクエスト対応

## 概要
VR空間上に配置したキャラの視線と顔の向きが、plyerの移動に合わせて追いかけるように動きます。
また、キャラに触れる箇所によって表情やポーズが変更され、反応してくれます。
胸を触ると、怒ってパンチされます。

## 作成背景
私が、初めて体験VRアプリが初音ミクがVR空間からこちらを見返してくるものでした。（あれは、今思うと初期バージョンのMikulusだったかもしれません）
その体験を改めてしたいと思った時、オキュラスクエストではそのアプリケーションが配信されていないことを知りました。
この経緯があり、あの時体験した感動をもう一度したいと思った私は、自分で作成し、新たな要素を追加したこのアプリを開発しました。

## 工夫した点
パンチアクションに合わせて、プレイヤーが後方に飛ぶようにしました。より後方に飛ぶ感覚になるよう、
コントローラーの振動、飛ばされるのに合わせてフェードアウトすることで遠くに飛ばされている演出を追加しました。

## 得た知見
OVRInput、VR空間上での移動方法、VRM形式の３Dモデルについて、フェードアウト　など

## 新たな課題
３Dモデルで扱うAnimatorの使用方法、OculuIntegrationの様々な機能の使用方法