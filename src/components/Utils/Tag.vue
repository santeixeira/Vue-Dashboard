<template>
  <div class="tag-input">
    <div
      v-for="(tag, index) in tags"
      :key="index"
      :tag="tag"
      class="tag-input__tag"
    >
      <span>x &nbsp;</span>
      {{ tag }}
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import tags from "@/interface/tags";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Tag",
  emits: ["addingTag"],
  data() {
    return {
      // tags: [] as tags[],
      tags: ["Node.js", "Python", "React.js"],
    };
  },
  methods: {
    addTag(): void {
      this.$emit("addingTag", {
        descricao: this.$data.tags,
      });
    },
    removeTag(index: number) {
      this.tags.splice(index, 1);
    },
  },
});
</script>
<style scoped lang="scss">
.tag-input {
  width: 100%;
  font-size: 0.9em;
  margin: 0 1em 0;
  
  padding: 0 1em;
}

.tag-input__tag {
  height: 0.2em;
  min-width: 0.5em;
  float: left;
  margin-right: 10px;
  background-color: #e84616;
  color: #fff;
  font-weight: 400;
  line-height: 30px;
  padding: 0 0.75em 2em;
  border-radius: 6px;
}

.tag-input__tag > span {
  cursor: pointer;
  opacity: 0.75;
}

.tag-input__text {
  border: none;
  outline: none;
  font-size: 0.9em;
  line-height: 50px;
  background: none;
}
</style>
